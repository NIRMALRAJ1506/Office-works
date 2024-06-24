import { createBrowserRouter } from "react-router-dom";
import { SliderComp } from "../components/SliderComp";
import MyImagesComp from "../components/MyImagesComp";
import ParentComp from "../components/ParentComp";
import { PageNotFound } from "../components/PageNotFound";
import { ReactHooksComp } from "../Hooks/ReactHooksComp";
import UseStateHookComp from "../Hooks/UseStateHookComp";
import UseEffectHookComp from "../Hooks/UseEffectHookComp";
import MaindashboardComp from "../Layout/MaindashboardComp";
import Dashboard from "../components/DashboardComp";
import VirtualDOMComp from "../components/VirtualDOMComp";
import { FormValComp } from "../components/FormValComp";
import ProductDashboardComp from "../CRUD/ProductDashboardComp";
import ProductAddComp from "../CRUD/ProductAddComp";
import ProductUpdateComp from "../CRUD/ProductUpdateComp";
import LoginComp from "../Layout/LoginComp";
import ProtectedRouting from "./ProtectedRouting";

const router=createBrowserRouter([
    {path:"",element:<LoginComp></LoginComp>},
    {path:"maindash",element:<ProtectedRouting Component={MaindashboardComp}/>,children:[
        {path:"",element:<SliderComp></SliderComp>},
        {path:"productadd",element:<ProductAddComp></ProductAddComp>},

    //naming routing
    {path:"slider",element:<SliderComp></SliderComp>},
    {path:"myimages",element:<MyImagesComp></MyImagesComp>},
    {path:"productdash",element:<ProductDashboardComp></ProductDashboardComp>},
    {path:"productupdate/:id",element:<ProductUpdateComp></ProductUpdateComp>},
    
    

    //parameterized routing
    {path:"parent/:id",element:<ParentComp></ParentComp>},
    {path:"parent",element:<ParentComp></ParentComp>},
    {path:"virtualdom",element:<VirtualDOMComp></VirtualDOMComp>},
    {path:"formval",element:<FormValComp></FormValComp>},

    //Child routing
    {path:"reacthook",element:<ReactHooksComp></ReactHooksComp>,children:[
        {path:"usestate",element:<UseStateHookComp></UseStateHookComp>},
        {path:"useeffect",element:<UseEffectHookComp></UseEffectHookComp>}
    ]},
    ]},
    //default routing
    {path:"dashboard",element:<Dashboard></Dashboard>,children:[
        {path:"slider",element:<SliderComp></SliderComp>},
    {path:"myimages",element:<MyImagesComp></MyImagesComp>},

    //parameterized routing
    {path:"parent/:id",element:<ParentComp></ParentComp>},
    {path:"parent",element:<ParentComp></ParentComp>},
    {path:"virtualdom",element:<VirtualDOMComp></VirtualDOMComp>},
    

    //Child routing
    {path:"reacthook",element:<ReactHooksComp></ReactHooksComp>,children:[
        {path:"usestate",element:<UseStateHookComp></UseStateHookComp>},
        {path:"useeffect",element:<UseEffectHookComp></UseEffectHookComp>}
    ]},
]},

    {path:"*",element:<PageNotFound></PageNotFound>}
])
export default router;