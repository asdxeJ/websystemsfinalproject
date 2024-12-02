import React from "react";
import bangusH from "../assets/HomePage/CustomerFavorites/bangusH.jpg";
import { Button } from "./Button";
import { Menu } from "../../Menu";

interface Props {
  menu: Menu;
}

const MenuCard: React.FC<Props> = ({ menu }): JSX.Element => {
  return (
    <>
      <div className="bg-black p-3 max-w-[230px]">
        <img className="border border-orange-600" src={bangusH} />
        <div className="text-white flex flex-col items-center justify-center font-inknut">
          <h3>{menu.name}</h3>
          <div className="flex gap-3">
            <p>{menu.price}</p>
            <Button>Order Now</Button>
          </div>
        </div>
      </div>
    </>
  );
};

export default MenuCard;
