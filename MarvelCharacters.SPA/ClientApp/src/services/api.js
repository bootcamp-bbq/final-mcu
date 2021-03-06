import axios from 'axios';

export const headerFactory = (token) => {
  return { headers: { "Authorization": `Bearer ${token}`, "Content-Type": "application/json" } }
}

const api = axios.create({
  baseURL: 'http://localhost:9000'
});

export default api;