import React, { Component } from "react";
import { Card, CardBody, CardTitle, Progress  } from "reactstrap";


const Scores = () => {
    return (
        <>
            <h1>Scores</h1>

            <div className="text-left">Food:</div>
            <Progress animated value={10} />

            <div className="text-left">Home:</div>
            <Progress animated color="success" value={25} />

            <div className="text-left">Travel:</div>
            <Progress animated color="warning" value={50} />

            <div className="text-left">Stuff:</div>
            <Progress animated color="danger" value={75} />
        </>
    );
}

export default Scores;
