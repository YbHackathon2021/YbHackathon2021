import React from "react";
import { Button, Jumbotron } from "reactstrap";
import colorService from "../services/colorService";

export const ChallengeDetails = ({
  userChallengeId,
  challenge,
  onAccept,
  onComplete,
  onClose,
  isActive,
}) => {
  const buttonStyle = { width: "100%", height: "80px", fontSize: "20px" };
  const color = colorService.getColorByTopic(challenge.topic);
  const image = `data:image/png;base64,${challenge.image.data}`;

  return (
    <>
      <Jumbotron>
        <h1 className="display-3">{challenge.title}</h1>
        <hr className="my-2" />
        <p className="lead">{challenge.description}</p>
      </Jumbotron>
      <img style={{ width: "100%" }} src={image} alt={challenge.topic}></img>

      {isActive ? (
        <Button
          style={buttonStyle}
          onClick={() => onComplete(userChallengeId)}
          color={color}
        >
          Complete Challenge
        </Button>
      ) : (
        <Button
          style={buttonStyle}
          onClick={() => onAccept(challenge.id)}
          color={color}
        >
          Accept Challenge
        </Button>
      )}
      <div className="h-divider-10"></div>
      <Button style={buttonStyle} onClick={onClose}>
        Back to Overview
      </Button>
      <div className="h-divider-10"></div>
    </>
  );
};
