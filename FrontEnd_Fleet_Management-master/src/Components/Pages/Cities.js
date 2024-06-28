import { useState, useEffect } from "react"; 


export default function Cities(props) { 
    const {citiesList} = props; 
    const [cityid,setCityid]=useState();
    const setid=(e)=>{
        setCityid(e.target.value)
    }
    console.log("ooooooo"+cityid)


    return (
        <section>
            <select>
                <option value="SelectCities"  >Select Cities</option>
                {citiesList.map(city => (
                    <option key={city.cityId} value={city.cityId} onChange={setid}>
                        {city.cityName}
                    </option> 
                ))}
            </select>
        </section>
    )
}