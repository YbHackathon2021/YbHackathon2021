import React, { useState, useEffect } from "react";
import { Button, Jumbotron } from "reactstrap";

export const WinnerGif = ({
    onClose
}) => {
    const buttonStyle = { width: "100%", height: "80px", fontSize: "20px" };
    const [imgUrl, setImgUrl] = useState("");

    useEffect(() => {
        // declare the async data fetching function
        const fetchData = async () => {
            const response = await fetch("https://g.tenor.com/v1/random?q=excited&key=KEY_HERE&limit=1&media_filter=basic");

            const json = await response.json();

            // set state with the result
            setImgUrl(json.results[0].media[0].gif.url);
        };

        // call the function
        fetchData()
            // make sure to catch any error
            .catch(console.error);
    }, []);

    return (
        <>
            <Jumbotron>
                <h1 className="display-3">CONGRATS</h1>
                <hr className="my-2" />
                <p className="lead">YOU DID IT</p>
            </Jumbotron>
            <div style={{textAlign: "center"}}>
                <img style={{ width: "50%" }} src={imgUrl}></img>
            </div>

            <Button style={buttonStyle} onClick={onClose}>
                Celebration finished
            </Button>
        </>
    );
};