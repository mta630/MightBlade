import React, { useEffect, useState } from "react";
import styles from './modules/app.module.css';
import axios from 'axios';
import Navbar from './Navbar.jsx';


const App = () => {
    const [user, setUser] = useState({});
    const [userList, setUserList] = useState([]);
    
    useEffect(() => {
        axios.get("api/user")
        .then((res) => {
            setUserList(res.data);
        })
        .catch((err) => {
            console.error(err);
        })
    }, [])

    return (
        <div className={styles.appContainer}>
            <Navbar />
            Hello
        </div>
    )
}

export default App;