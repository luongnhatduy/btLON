import { createStackNavigator, createAppContainer } from "react-navigation";
import Info from './info'
import Home from './Home'
import Login from './Login'
const AppNavigator = createStackNavigator({
    Login: {
        screen: Login
    },
    Info: {
        screen: Info
    },
    Home: {
        screen :Home
    }
});

export default createAppContainer(AppNavigator);