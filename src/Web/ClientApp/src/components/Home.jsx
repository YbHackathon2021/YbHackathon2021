import React, { Component } from "react";
import Challenges from "./Challenges";
import Scores from "./Scores";

export class Home extends Component {
  static displayName = Home.name;

  render() {
    return (
      <>
        <Scores />
        <div class="h-divider"></div>
        <Challenges />
      </>
    );
  }
}
