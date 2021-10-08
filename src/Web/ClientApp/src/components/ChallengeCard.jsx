import React from "react";
import { Card, CardBody, CardTitle } from "reactstrap";

export const ChallengeCard = ({ challenge, onSelected }) => {
  return (
    <>
      <Card
        onClick={onSelected}
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
