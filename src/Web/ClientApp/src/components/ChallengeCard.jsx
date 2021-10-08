import React from "react";
import { Card, CardBody, CardTitle, CardText } from "reactstrap";

export const ChallengeCard = ({ challenge, onSelected }) => {
  return (
    <>
      <Card onClick={onSelected} style={{ cursor: "pointer" }}>
        <CardBody>
          <CardTitle tag="h5">{challenge.title}</CardTitle>
          <CardText>{challenge.description}</CardText>
        </CardBody>
      </Card>
    </>
  );
};
