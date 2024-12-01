import { useEffect, useState } from "react";
import MenuCardList from "../components/MenuCardList";
import Navbar from "../components/Navbar";
import { getMenu } from "../../api";
import { Menu } from "../../Menu";

interface Props {}

const Menu = (props: Props) => {
  const [menu, setMenu] = useState<Menu[] | undefined>(undefined);

  useEffect(() => {
    const fetchData = async () => {
      const data = await getMenu(); //fetch menu data
      setMenu(data); // updates state
    };

    fetchData(); // trigger the fetch on component mount
  }, []);

  return (
    <>
      <div className="bg-home-bg min-h-screen bg-cover">
        <Navbar />
        <div>
          {/* Conditional rendering: only render MenuCardList if menu is defined */}
          {menu ? <MenuCardList menu={menu} /> : <p>Loading menu...</p>}
        </div>
      </div>
    </>
  );
};

export default Menu;
