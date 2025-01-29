import axios from "axios";

const apiClient = axios.create({
  baseURL: "http://localhost:5282/api",
  timeout: 10000,
  withCredentials: true,
});

apiClient.interceptors.request.use(
  (config) => {
    console.log(config);
    return config;
  },
  (error) => {
    console.error(error);
    return Promise.reject(error);
  }
);

apiClient.interceptors.response.use(
  (response) => {
    console.log(response);
    return response;
  },
  (error) => {
    console.error(error);
    return Promise.reject(error);
  }
);

export default apiClient;
