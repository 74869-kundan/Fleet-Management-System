import React, { useState, useEffect } from 'react';
import './LoginForm.css'; // You can create your own CSS file for styling

const LoginPage = () => {
  const [email, setEmail] = useState('');
  const [password, setPassword] = useState('');
  const [isLoggedIn, setIsLoggedIn] = useState(false);
  const [userData, setUserData] = useState(null); // To store fetched user data

  const handleLogin = async () => {
    if (email && password) {
      try {
        const response = await fetch(`http://localhost:8080/api/user/{emailId}/{password}`, {
         
          method: 'POST',
          headers: {
            'Content-Type': 'application/json',
          },
          body: JSON.stringify({ email, password }),
        });
  
        if (response.ok) {
          const userData = await response.json();
          setUserData(userData); // Store fetched user data
          setIsLoggedIn(true);
  
          // Fetch user data from middleware using the fetched user's email and password
          const middlewareResponse = await fetch(
            `http://localhost:8080/api/user/?email=${email}&password=${password}`,
            {
              method: 'GET',
              headers: {
                'Content-Type': 'application/json',
              },
            }
          );
  
          if (middlewareResponse.ok) {
            const middlewareData = await middlewareResponse.json();
            console.log('Middleware user data:', middlewareData);
          } else {
            console.error('Error fetching middleware data');
          }
        } else {
          console.error('Login failed');
        }
      } catch (error) {
        console.error('Error during login:', error);
      }
    }
  };
  
  const handleLogout = () => {
    setIsLoggedIn(false);
    setUserData(null);
  };

  return (
    <div className="login-page-container">
      {isLoggedIn ? (
        <div className="welcome-message">
          <h2>Welcome, {userData && userData.username}!</h2>
          <button onClick={handleLogout}>Logout</button>
        </div>
      ) : (
        <div className="login-form">
          <h2>Login</h2>
          <input
            type="email"
            placeholder="Email"
            value={email}
            onChange={e => setEmail(e.target.value)}
          />
          <input
            type="password"
            placeholder="Password"
            value={password}
            onChange={e => setPassword(e.target.value)}
          />
          <button onClick={handleLogin}>Login</button>
        </div>
      )}
      <div className="buttons">
        <button className="register-button">Register User</button>
        <button className="direct-booking-button">Direct Booking</button>
      </div>
    </div>
  );
};

export default LoginPage;
