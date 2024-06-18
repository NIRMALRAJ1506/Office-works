// import logo from './logo.svg';
import './App.css';
import ConditionRencomp from './Task/ConditionRenComp';
import SetStateComp from './Task/SetStateComp';
import ClassComp from './components/ClassComp';
import FunctionComp from './components/FunctionComp';
import MethodEventComp from './components/MethodEventComp';
import MyDetailsComp from './components/MyDetailsComp';
import MyImagesComp from './components/MyImagesComp';
import ParentComp from './components/ParentComp';


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
      {/* <MethodEventComp></MethodEventComp> */}
      {/* <SetStateComp></SetStateComp> */}
      {/* <ConditionRencomp></ConditionRencomp> */}
      {/* <MyImagesComp></MyImagesComp> */}
      <ParentComp></ParentComp>
    </div>
  );
}

export default App;
