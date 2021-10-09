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

  async fetchTips() {
    // const token = await authService.getAccessToken();
    // const response = await fetch("tips", {
    //   headers: !token ? {} : { Authorization: `Bearer ${token}` },
    // });
    // return await response.json();

    return [
      {
        id: "tip1",
        title: "Tip No 1",
        topic: "Food",
      },
    ];
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
