import authService from "./authorizeService";

export class ApiClient {
  async fetchUser() {
    const token = await authService.getAccessToken();
    const response = await fetch("users/current", {
      headers: !token ? {} : { Authorization: `Bearer ${token}` },
    });
    return await response.json();
  }

  async fetchChallenges() {
    const token = await authService.getAccessToken();
    const response = await fetch("challenges/userNotStarted", {
      headers: !token ? {} : { Authorization: `Bearer ${token}` },
    });
    return await response.json();
    }

  async fetchKeys() {
      const token = await authService.getAccessToken();
      const response = await fetch("Keys", {
          headers: !token ? {} : { Authorization: `Bearer ${token}` },
      });
      return await response.json();
  }

  async fetchTips() {
    const token = await authService.getAccessToken();
    const response = await fetch("tip", {
      headers: !token ? {} : { Authorization: `Bearer ${token}` },
    });
    return await response.json();

    // return [
    //   {
    //     id: "tip1",
    //     title: "Tip No 1",
    //     topic: "Food",
    //     teaser: "Bla bla bla bla",
    //     url: "https://google.com",
    //     imageUrl:
    //       "https://www.nachhaltigleben.ch/images/stories/Bilder%20Kooperation/Gutes_Gewissen_Sens_645.jpg",
    //   },
    // ];
  }

  async acceptChallenge(challengeId) {
    const token = await authService.getAccessToken();
    const response = await fetch(`userchallenges/challenge/${challengeId}`, {
      headers: !token ? {} : { Authorization: `Bearer ${token}` },
      method: "post",
    });
    await response.json();
  }

  async completeChallenge(userChallengeId) {
    const token = await authService.getAccessToken();
    const response = await fetch(`userchallenges/${userChallengeId}/win`, {
      headers: !token ? {} : { Authorization: `Bearer ${token}` },
      method: "post",
    });
    await response.json();
  }
}

const apiClient = new ApiClient();

export default apiClient;
