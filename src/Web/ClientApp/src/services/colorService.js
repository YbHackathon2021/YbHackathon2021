export class ColorService {
  getColorByTopic(topic) {
    switch (topic) {
      case "Food":
        return "primary";
      case "Home":
        return "success";
      case "Travel":
        return "warning";
      case "Stuff":
        return "danger";
      default:
        return "info";
    }
  }
}

const colorService = new ColorService();

export default colorService;
