import { createBrowserRouter } from "react-router-dom";
import { SliderComp } from "../components/SliderComp";
import MyImagesComp from "../components/MyImagesComp";
import ParentComp from "../components/ParentComp";
import { PageNotFound } from "../components/PageNotFound";
import { ReactHooksComp } from "../Hooks/ReactHooksComp";
import UseStateHookComp from "../Hooks/UseStateHookComp";
import UseEffectHookComp from "../Hooks/UseEffectHookComp";
import MaindashboardComp from "../Layout/MaindashboardComp";
const router=createBrowserRouter([
    {path:"maindash",element:<MaindashboardComp></MaindashboardComp>,children:[
        {path:"",element:<SliderComp></SliderComp>},

    //naming routing
    {path:"slider",element:<SliderComp></SliderComp>},
    {path:"myimages",element:<MyImagesComp></MyImagesComp>},

    //parameterized routing
    {path:"parent/:id",element:<ParentComp></ParentComp>},
    {path:"parent",element:<ParentComp></ParentComp>},

    //Child routing
    {path:"reacthook",element:<ReactHooksComp></ReactHooksComp>,children:[
        {path:"usestate",element:<UseStateHookComp></UseStateHookComp>},
        {path:"useeffect",element:<UseEffectHookComp></UseEffectHookComp>}
    ]},
    ]},
    //default routing
    

    {path:"*",element:<PageNotFound></PageNotFound>}
])
export default router;