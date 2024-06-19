// import logo from './logo.svg';
import './App.css';
import ConditionRencomp from './Task/ConditionRenComp';
import SetStateComp from './Task/SetStateComp';
import ClassComp from './components/ClassComp';
import ClickCounterComp from './components/ClickCounterComp';
import Dashboard from './components/DashboardComp';
import FunctionComp from './components/FunctionComp';
import HoverComp from './components/HoverComp';
import MethodEventComp from './components/MethodEventComp';
import MyDetailsComp from './components/MyDetailsComp';
import MyImagesComp from './components/MyImagesComp';
import MycssComp from './components/MycssComp';
import { PageNotFound } from './components/PageNotFound';
import ParentComp from './components/ParentComp';
import { SliderComp } from './components/SliderComp';






function App() {
  return (
    <div className="App">
      {/* <header className="App-header">
        <img src={logo} className="App-logo" alt="logo" />
        <p>
          Edit <code>src/App.js</code> and save to reload.
        </p>
        <a
          className="App-link"
          href="https://reactjs.org"
          target="_blank"
          rel="noopener noreferrer"
        >
          Learn React
        </a>
      </header> */}
      <h1>Welcome to Great Kirikaalan Magic Show</h1>
       {/*<FunctionComp myName="Nirmal Raj S" post="Software Developer" />
      <ClassComp myName="Sandhya" post="Software Developer" />
      <MyDetailsComp fname="Nirmal Raj" lname="S" email="nirmal@gmail.com" contact="75500064411"></MyDetailsComp> */}
        {/* <MethodEventComp></MethodEventComp>  */}
        {/* <SetStateComp></SetStateComp> 
        <ConditionRencomp></ConditionRencomp> 
        <MyImagesComp></MyImagesComp> 
        <ParentComp></ParentComp> */}
        {/* <MycssComp></MycssComp> */}
        {/* <ClickCounterComp></ClickCounterComp>
        <hr/>
        <HoverComp></HoverComp> */}
        {/* <SliderComp></SliderComp>
        <PageNotFound></PageNotFound> */}
        <Dashboard></Dashboard>
    </div>
  );
}

export default App;
