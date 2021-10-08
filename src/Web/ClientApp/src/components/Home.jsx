import React, { useState } from "react";
import { ChallengeDetails } from "./ChallengeDetails";
import Challenges from "./Challenges";
import Scores from "./Scores";

export const Home = () => {
  const [selectedChallenge, setSelectedChallenge] = useState(undefined);

  if (selectedChallenge) {
    return (
      <ChallengeDetails
        challenge={selectedChallenge}
        onClose={() => setSelectedChallenge(undefined)}
      />
    );
  } else {
    return (
      <>
        <Scores />
        <div class="h-divider"></div>
        <Challenges
          onSelected={(challenge) => setSelectedChallenge(challenge)}
        />
      </>
    );
  }
};
