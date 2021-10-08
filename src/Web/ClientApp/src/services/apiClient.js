import authService from "./authorizeService";

export class ApiClient {
  async fetchUser() {
    const token = await authService.getAccessToken();
    const response = await fetch("users/current", {
      headers: !token ? {} : { Authorization: `Bearer ${token}` },
    });
    let data = await response.json();
    console.log(data);

    // let data = {
    //   scores: [
    //     {
    //       topic: "Food",
    //       currentScore: 10,
    //     },
    //     {
    //       topic: "Home",
    //       currentScore: 20,
    //     },
    //     {
    //       topic: "Travel",
    //       currentScore: 30,
    //     },
    //     {
    //       topic: "Stuff",
    //       currentScore: 40,
    //     },
    //   ],
    //   challenges: [
    //     {
    //       challenge: {
    //         id: "abcd",
    //         topic: "Stuff",
    //         title: "Already heard about secondhand stores?",
    //         description:
    //           "Buying Seconhand clothes saves resources. Human and ecological resources. I claim that secondhand clothing is the most sustainable way to buy clothes, because no new resources are consumed. Offer for sale clothes that are already in circulation. It is important not to fall into a consumption frenzy because it is secondhand anyway. Only what really pleases and is needed, but above all also gives pleasure, should be bought.",
    //         pointsToEarn: 2,
    //         openFrom: "",
    //         openTo: "",
    //       },
    //       state: "open",
    //     },
    //     {
    //       challenge: {
    //         id: "abcd3",
    //         topic: "Food",
    //         title: "Food Challenge",
    //         Description: "",
    //         PointsToEarn: 2,
    //         OpenFrom: "",
    //         OpenTo: "",
    //       },
    //       state: "open",
    //     },
    //     {
    //       challenge: {
    //         id: "abcd2",
    //         topic: "Home",
    //         title: "Home Challenge",
    //         Description: "",
    //         PointsToEarn: 2,
    //         OpenFrom: "",
    //         OpenTo: "",
    //       },
    //       state: "open",
    //     },
    //     {
    //       challenge: {
    //         id: "abcd1",
    //         topic: "Stuff",
    //         title: "Challenge",
    //         Description: "",
    //         PointsToEarn: 2,
    //         OpenFrom: "",
    //         OpenTo: "",
    //       },
    //       state: "open",
    //     },
    //   ],
    // };

    return data;
  }

  async fetchChallenges() {
    // const token = await authService.getAccessToken();
    // const response = await fetch("challenges/userNotStarted", {
    //   headers: !token ? {} : { Authorization: `Bearer ${token}` },
    // });
    // return await response.json();

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

  async acceptChallenge(challengeId) {
    const token = await authService.getAccessToken();
    const response = await fetch(`userchallenges/challenge/${challengeId}`, {
      headers: !token ? {} : { Authorization: `Bearer ${token}` },
    });
    await response.json();
  }
}

const apiClient = new ApiClient();

export default apiClient;
