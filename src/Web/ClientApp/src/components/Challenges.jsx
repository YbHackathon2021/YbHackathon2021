import authService from "./api-authorization/AuthorizeService";
import React, { useState, useEffect } from "react";
import { Spinner } from "reactstrap";
import { ChallengeCard } from "./ChallengeCard";
import { ChallengeCatalog } from "./ChallengeCatalog";

export const Challenges = ({ onSelected }) => {
  const [activeChallenges, setActiveChallenges] = useState([]);
  const [isLoading, setIsLoading] = useState(true);

  useEffect(() => {
    // declare the async data fetching function
    const fetchData = async () => {
      const token = await authService.getAccessToken();
      const response = await fetch("weatherforecast", {
        headers: !token ? {} : { Authorization: `Bearer ${token}` },
      });
      let data = await response.json();

      data = [
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
      ];

      // set state with the result
      setActiveChallenges(data);
      setIsLoading(false);
    };

    // call the function
    fetchData()
      // make sure to catch any error
      .catch(console.error);
  }, []);

  const renderActiveChallenges = (challenges) => {
    return (
      <>
        {challenges.map((challenge) => (
          <ChallengeCard
            key={challenge.id}
            challenge={challenge}
            onSelected={() => onSelected(challenge, true)}
          />
        ))}
      </>
    );
  };

  return (
    <div>
      <h2>Challenges</h2>
      {isLoading ? (
        <Spinner type="grow" color="info" />
      ) : (
        <>
          {renderActiveChallenges(activeChallenges)}
          <div className="h-divider-50"></div>
          <ChallengeCatalog
            onShowChallengeDetails={(challenge) => onSelected(challenge, false)}
          />
        </>
      )}
    </div>
  );
};
