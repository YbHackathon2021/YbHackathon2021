import React from "react";
import { Progress } from "reactstrap";

export const Scores = () => {
  return (
    <>
      <h2>Scores</h2>

      <div className="text-left">Food:</div>
      <Progress animated color="primary" value={10} />

      <div className="text-left">Home:</div>
      <Progress animated color="success" value={25} />

      <div className="text-left">Travel:</div>
      <Progress animated color="warning" value={50} />

      <div className="text-left">Stuff:</div>
      <Progress animated color="danger" value={75} />
    </>
  );
};
