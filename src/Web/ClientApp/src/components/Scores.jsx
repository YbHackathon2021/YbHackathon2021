import React from "react";
import { Progress, Container, Row, Col, Badge } from "reactstrap";
import colorService from "../services/colorService";

export const Scores = ({ userData }) => {
  return (
    <>
      <Container>
        <Row>
          <Col xs="8">
            <h2>Scores</h2>

            {userData.scores.map((score) => (
              <React.Fragment>
                <div className="text-left">{score.topic}:</div>
                <Progress
                  animated
                  color={colorService.getColorByTopic(score.topic)}
                  value={score.currentScore}
                />
              </React.Fragment>
            ))}
          </Col>
          <Col xs="4">
            <h3>Achievements</h3>
            <Badge
              color="primary"
              pill
              style={{ marginLeft: "10", marginRight: "2" }}
            >
              Beginner
            </Badge>
            <Badge
              color="warning"
              pill
              style={{ marginLeft: "2", marginRight: "2" }}
            >
              Master
            </Badge>
            <Badge
              color="danger"
              pill
              style={{ marginLeft: "2", marginRight: "2" }}
            >
              Guru
            </Badge>
            <h3>Friends</h3>
            ...
          </Col>
        </Row>
      </Container>
    </>
  );
};
