import React from "react";
import { Button, Jumbotron } from "reactstrap";
import colorService from "../services/colorService";

export const ChallengeDetails = ({ challenge, onClose, isActive }) => {
  const buttonStyle = { width: "100%", height: "80px", fontSize: "20px" };
  const color = colorService.getColorByTopic(challenge.topic);
  return (
    <>
      <Jumbotron>
        <h1 className="display-3">{challenge.title}</h1>
        <hr className="my-2" />
        <p className="lead">{challenge.description}</p>
      </Jumbotron>

      {isActive ? (
        <Button style={buttonStyle} onClick={onClose} color={color}>
          Complete Challenge
        </Button>
      ) : (
        <Button style={buttonStyle} onClick={onClose} color={color}>
          Accept Challenge
        </Button>
      )}
      <div className="h-divider-10"></div>
      <Button style={buttonStyle} onClick={onClose}>
        Back to Overview
      </Button>
    </>
  );
};
