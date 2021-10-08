import authService from "./authorizeService";

export class ApiClient {
  async fetchUser() {
    const token = await authService.getAccessToken();
    const response = await fetch("weatherforecast", {
      headers: !token ? {} : { Authorization: `Bearer ${token}` },
    });
    let data = await response.json();

    data = {
      scores: [
        {
          topic: "Food",
          currentScore: 10,
        },
        {
          topic: "Home",
          currentScore: 20,
        },
        {
          topic: "Travel",
          currentScore: 30,
        },
        {
          topic: "Stuff",
          currentScore: 40,
        },
      ],
      challenges: [
        {
          challenge: {
            id: "abcd",
            topic: "Travel",
            title: "Travel Challenge",
            Description: "",
            PointsToEarn: 2,
            OpenFrom: "",
            OpenTo: "",
          },
          state: "lost",
        },
        {
          challenge: {
            id: "abcd3",
            topic: "Food",
            title: "Food Challenge",
            Description: "",
            PointsToEarn: 2,
            OpenFrom: "",
            OpenTo: "",
          },
          state: "open",
        },
        {
          challenge: {
            id: "abcd2",
            topic: "Home",
            title: "Home Challenge",
            Description: "",
            PointsToEarn: 2,
            OpenFrom: "",
            OpenTo: "",
          },
          state: "open",
        },
        {
          challenge: {
            id: "abcd1",
            topic: "Stuff",
            title: "Challenge",
            Description: "",
            PointsToEarn: 2,
            OpenFrom: "",
            OpenTo: "",
          },
          state: "open",
        },
      ],
    };

    return data;
  }

  async fetchChallenges() {
    const data = [
      {
        id: "abcd",
        topic: "Travel",
        title: "Travel Challenge",
        description: "",
        pointsToEarn: 2,
        openFrom: "",
        openTo: "",
      },
      {
        id: "abcd3",
        topic: "Food",
        title: "Food Challenge",
        description: "",
        pointsToEarn: 2,
        openFrom: "",
        openTo: "",
      },
    ];

    return data;
  }
}

const apiClient = new ApiClient();

export default apiClient;
