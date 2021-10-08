import React from "react";
import { Card, CardBody, CardTitle } from "reactstrap";
import colorService from "../services/colorService";

export const TipCard = ({ tip }) => {
  return (
    <>
      <Card>
        <CardBody>
          <CardTitle tag="h5" color={colorService.getColorByTopic(tip.topic)}>
            {tip.title}
          </CardTitle>
        </CardBody>
      </Card>
      <div className="h-divider-10"></div>
    </>
  );
};
