import React from "react";
import {
  Card,
  CardBody,
  CardTitle,
  CardImg,
  CardLink,
  CardSubtitle,
} from "reactstrap";
import colorService from "../services/colorService";

export const TipCard = ({ tip }) => {
  return (
    <>
      <Card>
        <CardBody>
          <CardImg top width="100%" src={tip.imageUrl} alt={tip.title} />
          <CardTitle tag="h5">{tip.title}</CardTitle>
          <CardSubtitle tag="h6" className="mb-2 text-muted">
            {tip.teaser}
          </CardSubtitle>
          <CardLink href={tip.url}>Read more</CardLink>
        </CardBody>
      </Card>
      <div className="h-divider-10"></div>
    </>
  );
};
