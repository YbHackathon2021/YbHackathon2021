import React, { useState, useEffect } from "react";
import { ChallengeDetails } from "./ChallengeDetails";
import { Challenges } from "./Challenges";
import { Scores } from "./Scores";
import authService from "./api-authorization/AuthorizeService";
import { Spinner } from "reactstrap";

export const Home = () => {
  const [selectedChallenge, setSelectedChallenge] = useState(undefined);
  const [userData, setUserData] = useState([]);
  const [isLoading, setIsLoading] = useState(true);

  useEffect(() => {
    // declare the async data fetching function
    const fetchData = async () => {
      const token = await authService.getAccessToken();
      const response = await fetch("weatherforecast", {
        headers: !token ? {} : { Authorization: `Bearer ${token}` },
      });
      let data = await response.json();

      data = {
        challenges: [
          {
            id: "abcd",
            topic: "Travel",
            title: "Travel Challenge",
            Description: "",
            PointsToEarn: 2,
            OpenFrom: "",
            OpenTo: "",
          },
          {
            id: "abcd3",
            topic: "Food",
            title: "Food Challenge",
            Description: "",
            PointsToEarn: 2,
            OpenFrom: "",
            OpenTo: "",
          },
          {
            id: "abcd2",
            topic: "Home",
            title: "Home Challenge",
            Description: "",
            PointsToEarn: 2,
            OpenFrom: "",
            OpenTo: "",
          },
          {
            id: "abcd1",
            topic: "Stuff",
            title: "Challenge",
            Description: "",
            PointsToEarn: 2,
            OpenFrom: "",
            OpenTo: "",
          },
        ],
      };

      // set state with the result
      setUserData(data);
      setIsLoading(false);
    };

    // call the function
    fetchData()
      // make sure to catch any error
      .catch(console.error);
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
        <Scores />
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
