import React from "react";
import { Badge } from "reactstrap";
import colorService from "../services/colorService";

export const AchievementBadge = ({ topic, score }) => {
  const color = colorService.getColorByTopic(topic);

  let label = "Noob";

  if (score > 20) {
    label = "Padawan";
  }

  if (score > 40) {
    label = "Everyman";
  }

  if (score > 60) {
    label = "Boss";
  }

  if (score > 80) {
    label = "Grandmaster";
  }

  return (
    <>
      <Badge color={color} pill style={{ fontSize: "20px", margin: "5px" }}>
        {`${topic} ${label}`}
      </Badge>
    </>
  );
};
