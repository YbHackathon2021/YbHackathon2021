import React from "react";
import { ChallengeCard } from "./ChallengeCard";
import { ChallengeCatalog } from "./ChallengeCatalog";

export const Challenges = ({
  userData,
  onActiveChallengeSelected,
  onNewChallengeSelected,
}) => (
  <>
    <h2>Challenges</h2>
    {userData.challenges
      .filter((userChallenge) => userChallenge.state === "open")
      .map((userChallenge) => (
        <ChallengeCard
          key={userChallenge.challenge.id}
          challenge={userChallenge.challenge}
          onSelected={() => onActiveChallengeSelected(userChallenge.challenge)}
        />
      ))}
    <div className="h-divider-50"></div>
    <ChallengeCatalog
      onShowChallengeDetails={(challenge) => onNewChallengeSelected(challenge)}
    />
  </>
);
