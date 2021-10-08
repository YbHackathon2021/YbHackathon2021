import authService from "./api-authorization/AuthorizeService";
import React, { useState, useEffect } from "react";

const Challenges = () => {
  const [challenges, setChallenges] = useState([]);
  const [isLoading, setIsLoading] = useState(true);

  useEffect(() => {
    // declare the async data fetching function
    const fetchData = async () => {
      const token = await authService.getAccessToken();
      const response = await fetch("weatherforecast", {
        headers: !token ? {} : { Authorization: `Bearer ${token}` },
      });
      const data = await response.json();

      // set state with the result
      setChallenges(data);
      setIsLoading(false);
    };

    // call the function
    fetchData()
      // make sure to catch any error
      .catch(console.error);
  }, []);

  const renderChallenges = (forecasts) => {
    return (
      <table className="table table-striped" aria-labelledby="tabelLabel">
        <thead>
          <tr>
            <th>Date</th>
            <th>Temp. (C)</th>
            <th>Temp. (F)</th>
            <th>Summary</th>
          </tr>
        </thead>
        <tbody>
          {forecasts.map((forecast) => (
            <tr key={forecast.date}>
              <td>{forecast.date}</td>
              <td>{forecast.temperatureC}</td>
              <td>{forecast.temperatureF}</td>
              <td>{forecast.summary}</td>
            </tr>
          ))}
        </tbody>
      </table>
    );
  };

  const contents = isLoading ? (
    <p>
      <em>Loading...</em>
    </p>
  ) : (
    renderChallenges(challenges)
  );

  return (
    <div>
      <h1 id="tabelLabel">Weather forecast</h1>
      <p>This component demonstrates fetching data from the server.</p>
      {contents}
    </div>
  );
};

export default Challenges;
