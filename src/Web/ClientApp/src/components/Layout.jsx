import React, { Component } from "react";
import { Container } from "reactstrap";
import { NavMenu } from "./NavMenu";

export class Layout extends Component {
  static displayName = Layout.name;

  render() {
    return (
      <div>
        <NavMenu />
        <Container>
          {this.props.children}
          <span style={{ fontSize: "10px", marginRight: "5px" }}>
            powerd by
          </span>
          <span>
            <img
              style={{ height: "20px" }}
              src={process.env.PUBLIC_URL + "/bekb-logo.png"}
              alt="Logo BEKB"
            />
          </span>
          <div className="h-divider-10" />
        </Container>
      </div>
    );
  }
}
