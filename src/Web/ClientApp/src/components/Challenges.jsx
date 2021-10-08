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
    {userData.challenges.map((challenge) => (
      <ChallengeCard
        key={challenge.id}
        challenge={challenge}
        onSelected={() => onActiveChallengeSelected(challenge)}
      />
    ))}
    <div className="h-divider-50"></div>
    <ChallengeCatalog
      onShowChallengeDetails={(challenge) => onNewChallengeSelected(challenge)}
    />
  </>
);
