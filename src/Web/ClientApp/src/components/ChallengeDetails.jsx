import React from "react";
import { Button } from "reactstrap";

export const ChallengeDetails = ({ challenge, onClose, isActive }) => {
  return (
    <>
      <h3>{challenge.title}</h3>
      <Button onClick={onClose}>exit</Button>

      {isActive ? (
        <Button onClick={onClose}>Complete</Button>
      ) : (
        <Button onClick={onClose}>Accept</Button>
      )}
    </>
  );
};
