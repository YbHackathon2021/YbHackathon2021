import authService from "./components/api-authorization/AuthorizeService";

export class ApiClient {
  async fetchUser() {
    const token = await authService.getAccessToken();
    const response = await fetch("weatherforecast", {
      headers: !token ? {} : { Authorization: `Bearer ${token}` },
    });
    let data = await response.json();

    data = {
      challenges: [
        {
          id: "abcd",
          topic: "Travel",
          title: "Travel Challenge",
          Description: "",
          PointsToEarn: 2,
          OpenFrom: "",
          OpenTo: "",
        },
        {
          id: "abcd3",
          topic: "Food",
          title: "Food Challenge",
          Description: "",
          PointsToEarn: 2,
          OpenFrom: "",
          OpenTo: "",
        },
        {
          id: "abcd2",
          topic: "Home",
          title: "Home Challenge",
          Description: "",
          PointsToEarn: 2,
          OpenFrom: "",
          OpenTo: "",
        },
        {
          id: "abcd1",
          topic: "Stuff",
          title: "Challenge",
          Description: "",
          PointsToEarn: 2,
          OpenFrom: "",
          OpenTo: "",
        },
      ],
    };

    return data;
  }
}

const apiClient = new ApiClient();

export default apiClient;
