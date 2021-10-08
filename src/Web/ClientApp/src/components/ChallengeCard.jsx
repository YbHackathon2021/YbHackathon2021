import React from "react";
import { Card, CardBody, CardTitle } from "reactstrap";
import colorService from "../services/colorService";

export const ChallengeCard = ({ challenge, onSelected }) => {
  return (
    <>
      <Card
        onClick={onSelected}
        color={colorService.getColorByTopic(challenge.topic)}
        style={{ cursor: "pointer", backgroundColor: "darkgrey" }}
      >
        <CardBody>
          <CardTitle tag="h5">{challenge.title}</CardTitle>
        </CardBody>
      </Card>
      <div className="h-divider-10"></div>
    </>
  );
};
