import React from "react";
import { Progress, Container, Row, Col, Badge } from "reactstrap";

export const Scores = () => {
  return (
    <>
        <Container>
            <Row>
                <Col xs="8">
                    <h2>Scores</h2>

                    <div className="text-left">Food:</div>
                    <Progress animated color="primary" value={10} />

                    <div className="text-left">Home:</div>
                    <Progress animated color="success" value={25} />

                    <div className="text-left">Travel:</div>
                    <Progress animated color="warning" value={50} />

                    <div className="text-left">Stuff:</div>
                    <Progress animated color="danger" value={75} />
                </Col>
                <Col xs="4">
                      <h3>Achievements</h3>
                      <Badge color="primary" pill style={{ marginLeft: "10", marginRight: "2" }}>Beginner</Badge>
                      <Badge color="warning" pill style={{ marginLeft: "2", marginRight: "2" }}>Master</Badge>
                      <Badge color="danger" pill style={{ marginLeft: "2", marginRight: "2" }}>Guru</Badge>
                      <h3>Friends</h3>
                      ...
                </Col>
            </Row>
        </Container>

    </>
  );
};
