import React, { useState, useEffect } from "react";
import { Spinner, Carousel, CarouselControl, CarouselItem } from "reactstrap";
import apiClient from "../services/apiClient";
import { ChallengeCard } from "./ChallengeCard";

export const ChallengeCatalog = ({ onShowChallengeDetails }) => {
  const [challenges, setChallenges] = useState([]);
  const [isLoading, setIsLoading] = useState(true);
  const [activeIndex, setActiveIndex] = useState(0);
  const [animating, setAnimating] = useState(false);

  useEffect(() => {
    // declare the async data fetching function
    const fetchData = async () => {
      const data = await apiClient.fetchChallenges();

      // set state with the result
      setChallenges(data);
      setIsLoading(false);
    };

    // call the function
    fetchData()
      // make sure to catch any error
      .catch(console.error);
  }, []);

  const next = () => {
    if (animating) return;
    const nextIndex =
      activeIndex === challenges.length - 1 ? 0 : activeIndex + 1;
    setActiveIndex(nextIndex);
  };

  const previous = () => {
    if (animating) return;
    const nextIndex =
      activeIndex === 0 ? challenges.length - 1 : activeIndex - 1;
    setActiveIndex(nextIndex);
  };

  if (isLoading) {
    return <Spinner type="grow" color="info" />;
  }

  const slides = challenges.map((item) => {
    return (
      <CarouselItem
        onExiting={() => setAnimating(true)}
        onExited={() => setAnimating(false)}
        key={item.id}
      >
        {/* <img src={item.src} alt={item.title} /> */}
        {/* <Button style="width: 100%">Show Details</Button> */}
        <ChallengeCard
          challenge={item}
          onSelected={() => onShowChallengeDetails(item)}
        />
        {/* <CarouselCaption captionText={item.title} captionHeader={item.title} /> */}
      </CarouselItem>
    );
  });

  return (
    <>
      <h5>New Challenges</h5>
      <Carousel activeIndex={activeIndex} next={next} previous={previous}>
        {/* <CarouselIndicators
          items={challenges}
          activeIndex={activeIndex}
          onClickHandler={goToIndex}
        /> */}
        {slides}
        <CarouselControl
          direction="prev"
          directionText="Previous"
          onClickHandler={previous}
        />
        <CarouselControl
          direction="next"
          directionText="Next"
          onClickHandler={next}
        />
      </Carousel>
    </>
  );
};
