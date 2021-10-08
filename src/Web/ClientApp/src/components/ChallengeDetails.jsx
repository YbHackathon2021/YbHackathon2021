import React from "react";
import { Button } from "reactstrap";

export const ChallengeDetails = ({ challenge, onClose }) => {
  return (
    <>
      <h3>{challenge.title}</h3>
      <Button onClick={onClose}>exit</Button>
    </>
  );
};
