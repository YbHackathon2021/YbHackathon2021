import React from "react";
import { Button, Jumbotron, Container, Row, Col } from "reactstrap";
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

  console.log(challenge);

  return (
    <>
      <img style={{ width: "100%" }} src={image} alt={challenge.topic}></img>
      <Jumbotron>
        <h1 className="display-3">{challenge.title}</h1>
        <hr className="my-2" />
        <p className="lead">{challenge.description}</p>
      </Jumbotron>
      <div className="h-divider-100"></div>
      <Container>
        <Row>
          <Col xs="12" md="6" style={{ textAlign: "center" }}>
            <svg
              xmlns="http://www.w3.org/2000/svg"
              height="50"
              width="50"
              fill="currentColor"
              class="bi bi-graph-up"
              viewBox="0 0 16 16"
            >
              <path
                fill-rule="evenodd"
                d="M0 0h1v15h15v1H0V0zm10 3.5a.5.5 0 0 1 .5-.5h4a.5.5 0 0 1 .5.5v4a.5.5 0 0 1-1 0V4.9l-3.613 4.417a.5.5 0 0 1-.74.037L7.06 6.767l-3.656 5.027a.5.5 0 0 1-.808-.588l4-5.5a.5.5 0 0 1 .758-.06l2.609 2.61L13.445 4H10.5a.5.5 0 0 1-.5-.5z"
              />
            </svg>
            <p class="lead">Challenge Reward</p>
            <h3>{`+ ${challenge.pointsToEarn} ${challenge.topic} points`}</h3>
            <div className="h-divider-10"></div>
          </Col>
          <Col xs="12" md="6" style={{ textAlign: "center" }}>
            <svg
              xmlns="http://www.w3.org/2000/svg"
              fill="currentColor"
              class="bi bi-alarm"
              viewBox="0 0 16 16"
              height="50"
              width="50"
            >
              <path d="M8.5 5.5a.5.5 0 0 0-1 0v3.362l-1.429 2.38a.5.5 0 1 0 .858.515l1.5-2.5A.5.5 0 0 0 8.5 9V5.5z" />
              <path d="M6.5 0a.5.5 0 0 0 0 1H7v1.07a7.001 7.001 0 0 0-3.273 12.474l-.602.602a.5.5 0 0 0 .707.708l.746-.746A6.97 6.97 0 0 0 8 16a6.97 6.97 0 0 0 3.422-.892l.746.746a.5.5 0 0 0 .707-.708l-.601-.602A7.001 7.001 0 0 0 9 2.07V1h.5a.5.5 0 0 0 0-1h-3zm1.038 3.018a6.093 6.093 0 0 1 .924 0 6 6 0 1 1-.924 0zM0 3.5c0 .753.333 1.429.86 1.887A8.035 8.035 0 0 1 4.387 1.86 2.5 2.5 0 0 0 0 3.5zM13.5 1c-.753 0-1.429.333-1.887.86a8.035 8.035 0 0 1 3.527 3.527A2.5 2.5 0 0 0 13.5 1z" />
            </svg>
            <p class="lead">End of Challenge</p>
            <h3>{challenge.openTo.split("T")[0]}</h3>
          </Col>
        </Row>
      </Container>
      <div className="h-divider-100"></div>
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
