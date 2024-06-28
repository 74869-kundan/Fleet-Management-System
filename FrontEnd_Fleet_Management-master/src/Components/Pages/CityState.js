    import { useState } from "react"; 
    import States from "./States";
    import Cities from "./Cities"; 
    import Popup from "./Popup";

    export default function CityState(props) {
        const [citiesList, setCitiesList] = useState([]);
        const { datacityState,sendDataToParent } = props;
        const sendDataToParentOnClick = () => {
        // Simulate data to send back to the parent component
        const dataToSend = { cityId: citiesList.cityId };
        console.log("Data to send  ="+dataToSend)
        // Call the callback function to send data to the parent component
        sendDataToParent(dataToSend);

        // {sendDataToParentOnClick}
    };
    


        return (
            <section>
                    <td><label for='loc'>Enter State</label></td>
                    <td> <States setCitiesList={setCitiesList} citiesList={citiesList} ></States> </td>
                    <td> <Cities citiesList={citiesList} ></Cities> </td>
                    <td><button onClick={sendDataToParentOnClick}>Search</button></td>
                    {/* <td><Popup/></td> */}
                    <td></td>
                    
            </section>
        )

    }