import MenuCardList from "../components/MenuCardList";
import Navbar from "../components/Navbar";

interface Props {}

const Menu = (props: Props) => {
  return (
    <>
      <div className="bg-home-bg h-screen bg-cover">
        <Navbar />
        <div>
          <MenuCardList />
        </div>
      </div>
    </>
  );
};

export default Menu;
