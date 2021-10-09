import React, { useState, useEffect } from "react";
import { TipCard } from "./TipCard";
import { Spinner } from "reactstrap";
import apiClient from "../services/apiClient";

export const Tips = () => {
  const [tips, setTips] = useState([]);
  const [isLoading, setIsLoading] = useState(true);

  useEffect(() => {
    // declare the async data fetching function
    const fetchData = async () => {
      const data = await apiClient.fetchTips();

      // set state with the result
      setTips(data);
      setIsLoading(false);
    };

    // call the function
    fetchData()
      // make sure to catch any error
      .catch(console.error);
  }, []);

  if (isLoading) {
    return <Spinner type="grow" color="info" />;
  }

  return (
    <>
      <h2 class="display-4">Tips</h2>
      {tips.map((tip) => (
        <TipCard key={tip.id} tip={tip} />
      ))}
    </>
  );
};
