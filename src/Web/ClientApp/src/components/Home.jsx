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
  }, []);

  if (isLoading) {
    return <Spinner type="grow" color="info" />;
  } else if (selectedChallenge) {
    return (
      <ChallengeDetails
        challenge={selectedChallenge.challenge}
        isActive={selectedChallenge.isActive}
        onClose={() => setSelectedChallenge(undefined)}
      />
    );
  } else {
    return (
      <>
        <Scores userData={userData} />
        <div className="h-divider-50"></div>
        <Challenges
          userData={userData}
          onActiveChallengeSelected={(challenge) =>
            setSelectedChallenge({ challenge, isActive: true })
          }
          onNewChallengeSelected={(challenge) =>
            setSelectedChallenge({ challenge, isActive: false })
          }
        />
      </>
    );
  }
};
