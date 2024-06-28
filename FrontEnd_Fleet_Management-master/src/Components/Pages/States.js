import { useState, useEffect } from "react"

export default function States(props) { 
    
    const {citiesList, setCitiesList} = props; 
    let [stateId, setStateId] = useState(0); 

    function stateHandler(event) {
        stateId = event.target.value; 
        console.log("-> " + stateId); 
        setStateId(stateId); 
    }


    useEffect(() => {
        fetch("http://localhost:8080/api/cities/" + stateId) 
            .then(res => res.json())
            .then((result) => { setCitiesList(result) }
            );
    }, [citiesList]);


    return (
        <section>
            <select onChange={stateHandler}>
                <option value="SelectState">Select State</option>
                <option value="1">ANDAMAN AND NICOBAR ISLANDS</option>
                <option value="2">ANDHRA PRADESH</option>
                <option value="3">ARUNACHAL PRADESH</option>
                <option value="4">ASSAM</option>
                <option value="5">BIHAR</option>
                <option value="6">CHATTISGARH</option>
                <option value="7">CHANDIGARH</option>
                <option value="8">DAMAN AND DIU</option>
                <option value="9">DELHI</option>
                <option value="10">DADRA AND NAGAR HAVELI</option>
                <option value="11">GOA</option>
                <option value="12">GUJARAT</option>
                <option value="13">HIMACHAL PRADESH</option>
                <option value="14">HARYANA</option>
                <option value="15">JAMMU AND KASHMIR</option>
                <option value="16">JHARKHAND</option>
                <option value="17">KERALA</option>
                <option value="18">KARNATAKA</option>
                <option value="19">LAKSHADWEEP</option>
                <option value="20">MEGHALAYA</option>
                <option value="21">MAHARASHTRA</option>
                <option value="22">MANIPUR</option>
                <option value="23">MADHYA PRADESH</option>
                <option value="24">MIZORAM</option>
                <option value="25">NAGALAND</option>
                <option value="26">ORISSA</option>
                <option value="27">PUNJAB</option>
                <option value="28">PONDICHERRY</option>
                <option value="29">RAJASTHAN</option>
                <option value="30">SIKKIM</option>
                <option value="31">TAMIL NADU</option>
                <option value="32">TRIPURA</option>
                <option value="33">UTTARAKHAND</option>
                <option value="34">UTTAR PRADESH</option>
                <option value="35">WEST BENGAL</option>
                <option value="36">TELANGANA</option>
            </select>

        </section>
    )
}