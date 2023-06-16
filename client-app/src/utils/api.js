import axios from "axios";

const api = axios.create({
    baseURL:'http://localhost:5000',
    headers: {
        'Content-Type': 'application/json'
    }
});

api.interceptors.response.use(
    (res) => res,
    (err) => {
        console.log(err.response)
    }
)

export default api;