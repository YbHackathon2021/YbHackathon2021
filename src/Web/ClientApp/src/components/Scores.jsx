import React from "react";
import { Progress, Row, Col, Badge } from "reactstrap";
import colorService from "../services/colorService";

export const Scores = ({ userData }) => {
  return (
    <>
      <Row>
        <Col xs="12" md="8">
          <h2 class="display-4">Scores</h2>

          {userData.scores.map((score) => (
            <React.Fragment>
              <div className="text-left">{score.topic}:</div>
              <Progress
                animated
                color={colorService.getColorByTopic(score.topic)}
                value={score.currentScore}
                style={{ height: "40px" }}
              />
              <Progress
                color="secondary"
                value={
                  score.topic === "Food"
                    ? 45
                    : score.topic === "Travel"
                    ? 25
                    : score.topic === "Home"
                    ? 70
                    : 35
                }
              />
            </React.Fragment>
          ))}
          <div className="h-divider-100"></div>
        </Col>
        <Col xs="12" md="4">
          <h2 class="display-4">Achievements</h2>
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
          <div className="h-divider-100"></div>
          <h2 class="display-4">Friends</h2>
          ...
        </Col>
      </Row>
    </>
  );
};
