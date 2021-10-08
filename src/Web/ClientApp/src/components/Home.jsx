import React, { useState, useEffect } from "react";
import { ChallengeDetails } from "./ChallengeDetails";
import { Challenges } from "./Challenges";
import { Scores } from "./Scores";
import { Spinner } from "reactstrap";
import apiClient from "../services/apiClient";

export const Home = () => {
  const [selectedChallenge, setSelectedChallenge] = useState(undefined);
  const [userData, setUserData] = useState([]);
  const [isLoading, setIsLoading] = useState(true);

  useEffect(() => {
    // declare the async data fetching function
    const fetchData = async () => {
      const data = await apiClient.fetchUser();

      // set state with the result
      setUserData(data);
      setIsLoading(false);
    };

    // call the function
    fetchData().catch(console.error);
  }, [selectedChallenge]);

  const accept = async (challengeId) => {
    await apiClient.acceptChallenge(challengeId);
    setSelectedChallenge(undefined);
  };

  const complete = async (userChallengeId) => {
    await apiClient.completeChallenge(userChallengeId);
    setSelectedChallenge(undefined);
  };

  if (isLoading) {
    return <Spinner type="grow" color="info" />;
  } else if (selectedChallenge) {
    return (
      <ChallengeDetails
        userChallengeId={selectedChallenge.userChallengeId}
        challenge={selectedChallenge.challenge}
        isActive={selectedChallenge.isActive}
        onAccept={accept}
        onComplete={complete}
        onClose={() => setSelectedChallenge(undefined)}
      />
    );
  } else {
    console.log(userData);

    return (
      <>
        <Scores userData={userData} />
        <div className="h-divider-50"></div>
        <Challenges
          userData={userData}
          onActiveChallengeSelected={(challenge, userChallengeId) =>
            setSelectedChallenge({
              challenge,
              isActive: true,
              userChallengeId: userChallengeId,
            })
          }
          onNewChallengeSelected={(challenge) =>
            setSelectedChallenge({
              challenge,
              isActive: false,
            })
          }
        />
      </>
    );
  }
};
