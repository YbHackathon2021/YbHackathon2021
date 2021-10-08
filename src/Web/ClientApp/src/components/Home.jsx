import React, { useState } from "react";
import { ChallengeDetails } from "./ChallengeDetails";
import { Challenges } from "./Challenges";
import { Scores } from "./Scores";

export const Home = () => {
  const [selectedChallenge, setSelectedChallenge] = useState(undefined);
  const [isSelectedChallengeActive, setIsSelectedChallengeActive] =
    useState(undefined);

  if (selectedChallenge) {
    return (
      <ChallengeDetails
        challenge={selectedChallenge}
        onClose={() => setSelectedChallenge(undefined)}
        isActive={isSelectedChallengeActive}
      />
    );
  } else {
    return (
      <>
        <Scores />
        <div className="h-divider-50"></div>
        <Challenges
          onSelected={(challenge, isActive) => {
            setSelectedChallenge(challenge);
            setIsSelectedChallengeActive(isActive);
          }}
        />
      </>
    );
  }
};
