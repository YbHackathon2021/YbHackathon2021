import React from "react";
import { ChallengeCard } from "./ChallengeCard";
import { ChallengeCatalog } from "./ChallengeCatalog";

export const Challenges = ({
  userData,
  onActiveChallengeSelected,
  onNewChallengeSelected,
}) => (
  <>
    <h2 class="display-4">Challenges</h2>
    <h5>Active</h5>
    {userData.userChallenges
      .filter((userChallenge) => userChallenge.state === "open")
      .map((userChallenge) => (
        <ChallengeCard
          key={userChallenge.challenge.id}
          challenge={userChallenge.challenge}
          onSelected={() =>
            onActiveChallengeSelected(userChallenge.challenge, userChallenge.id)
          }
        />
      ))}
    <div className="h-divider-100"></div>
    <ChallengeCatalog
      onShowChallengeDetails={(challenge) => onNewChallengeSelected(challenge)}
    />
  </>
);
