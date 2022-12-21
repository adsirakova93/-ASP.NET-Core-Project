import { Email, EmailOutlined, LinkedIn, LocationCity, Phone, PhoneAndroidOutlined } from '@material-ui/icons'
import React from 'react'
import styled from 'styled-components'
import {medium, small} from "../responsive"

const MainContainer=styled.div`
height: 100%;
background-color: #8F3985;
color: black;
`
const InnerContainer=styled.div`
display:flex;
justify-content: space-between;
padding: 1rem;
gap:3rem;
${small({display:"inline"})}
`
const Left=styled.div`
display: flex;
flex-direction: column;
align-items: center;
flex:2;
`
const Right=styled.div`
display: flex;
flex-direction: column;
align-items: flex-start;
flex:1;
`
const OwnerDiv=styled.div`
display: flex;
height: 2rem;
background-color: black;
color: white;
align-items: center;
justify-content: space-between;
${medium({display:"none"})}
`

export default function Footer() {
    return (
        <>
        <MainContainer>
            <InnerContainer>
                <Left>
                    <div><h2 style={{textAlign:"start"}}>E-store</h2></div>
                        <div><p>The most beautiful makeup of a woman is passion. But cosmetics are easier to buy.</p></div>
                </Left>
                <Right>
                <div><h2 style={{textAlign:"start"}}>Contact Us</h2></div>
                <div><p><LocationCity/> Radost 6, Varna, Bulgaria</p></div>
                <div><p><Email/> adsirakova.93@gmail.com</p></div>
                <div><p><Phone/> +359/ 789-465-321</p></div>
                </Right>
            </InnerContainer>
        </MainContainer>
        <OwnerDiv>
            <div>
                Developed by Anastasia Sirakova
            </div>
             
        </OwnerDiv>
        </>
    )
}
