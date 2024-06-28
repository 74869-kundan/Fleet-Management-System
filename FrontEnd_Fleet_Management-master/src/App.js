import './App.css';
import { Routes, Route, BrowserRouter, Outlet } from 'react-router-dom'

import Header from './Components/Layouts/Header/Header';
import Home from './Components/Pages/Home'
import CancelBooking from './Components/Pages/Cancel_Booking'
import Footer from './Components/Layouts/Footer/Footer';
import Vehicle_Selection from './Components/Pages/VehicleSelection/Vehicle_Selection';
import Addon from './Components/Pages/Addon/Addon';
import LocationSelector from './Components/Pages/LocationSelector/LocationSelector'
import Login from './Components/Pages/Login/Login'
import Registration from './Components/Pages/Register/Registration'
import AboutUs from './Components/Pages/AboutUs/AboutIndiaDrive'
import CustomerCare from './Components/Pages/CustomerCare/CustomerCare'


function App() {
  return (
    <div>
      <Header />
      <BrowserRouter>
        <Routes>
          <Route path='/' >
          <Route path='/' element={<Home />}/>
          <Route path='/Home' element={<Home />}/>
          <Route path='/Modify' element={<CancelBooking />}/>
          <Route path='/Addon' element={<Addon />}/>
          {/* <Route path='/LocationSelector' element={<LocationSelector />}/> */}
          <Route path='/LocationSelector/:userId' element={<LocationSelector />}/>
          <Route path='/Login' element={<Login />}/>
          <Route path='/Registration' element={<Registration />}/>
          <Route path='/AboutUs' element={<AboutUs />}/>
          <Route path='/CustomerCare' element={<CustomerCare />}/>
          </Route>
        </Routes>
        <Outlet/>
      </BrowserRouter>
      
      <Footer/>

    </div>
  );
}

export default App;
