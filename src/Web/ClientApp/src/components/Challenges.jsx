import authService from "./api-authorization/AuthorizeService";
import React, { useState, useEffect } from "react";
import { Spinner } from "reactstrap";
import ChallengeCard from "./ChallengeCard";

const Challenges = ({ onSelected }) => {
  const [challenges, setChallenges] = useState([]);
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
      setChallenges(data);
      setIsLoading(false);
    };

    // call the function
    fetchData()
      // make sure to catch any error
      .catch(console.error);
  }, []);

  const renderChallenges = (challenges) => {
    return (
      <>
        {challenges.map((challenge) => (
          <ChallengeCard
            key={challenge.id}
            challenge={challenge}
            onSelected={() => onSelected(challenge)}
          />
        ))}
      </>
    );
  };

  return (
    <div>
      <h1>Challenges</h1>
      {isLoading ? (
        <p>
          <Spinner type="grow" color="info" />
        </p>
      ) : (
        renderChallenges(challenges)
      )}
    </div>
  );
};

export default Challenges;
