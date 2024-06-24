const redux=require('redux')
const createStore=redux.createStore


// action 

const WIDROW_MONEY="WIDROW-MONEY"
const DEPOSIT_MONEY="DEPOSIT-MONEY"
function widrowmoney(){
    return{
        type:WIDROW_MONEY
    }
}
function depositmoney(){
    return{
        type:DEPOSIT_MONEY
    }
}


//reducer(state,action)=>
    const initialState={
        totalMoney:10000
    }

    const reducer=(state=initialState,action)=>{
        switch(action.type){
            case "WIDROW-MONEY":return{
                ...state,
                totalMoney:state.totalMoney-1000
            }
            case "DEPOSIT-MONEY":return{
                ...state,
                totalMoney:state.totalMoney+1000
            }
            default:return state
        }
    }


    // store code

    const store= createStore(reducer)
    console.log("initial; State",store.getState())
    store.subscribe(()=>console.log("updated state is : ",store.getState()))
    store.dispatch(widrowmoney())
    store.dispatch(widrowmoney())
    store.dispatch(depositmoney())
    store.dispatch(depositmoney())