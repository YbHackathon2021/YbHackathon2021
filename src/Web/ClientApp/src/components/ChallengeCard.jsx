import React from "react";
import { Card, CardBody, CardTitle, CardImg } from "reactstrap";
import colorService from "../services/colorService";

export const ChallengeCard = ({ challenge, onSelected }) => {
  const image = `data:image/png;base64,${challenge.image.data}`;

  return (
    <>
      <Card
        onClick={onSelected}
        color={colorService.getColorByTopic(challenge.topic)}
        style={{ cursor: "pointer", backgroundColor: "darkgrey" }}
      >
        <CardImg top width="100%" src={image} alt={challenge.title} />
        <CardBody>
          <CardTitle tag="h5">{challenge.title}</CardTitle>
        </CardBody>
      </Card>
      <div className="h-divider-10"></div>
    </>
  );
};
