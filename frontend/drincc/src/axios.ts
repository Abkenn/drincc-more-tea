import axios from "axios";
export default axios.create({
  baseURL: "https://localhost:7268/",
  headers: {
    "Content-type": "application/json"
  }
});