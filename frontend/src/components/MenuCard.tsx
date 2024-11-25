import React from "react";
import bangusH from "../assets/HomePage/CustomerFavorites/bangusH.jpg";
import { Button } from "./Button";

interface Props {}

const Card = (props: Props) => {
  return (
    <>
      <div className="bg-black p-3 min-w-50">
        <img className="border border-orange-600" src={bangusH} />
        <div className="text-white flex flex-col items-center justify-center font-inknut">
          <h3>Bangus/Hotdog</h3>
          <div className="flex gap-3">
            <p>$99.00</p>
            <Button>Order Now</Button>
          </div>
        </div>
      </div>
    </>
  );
};

export default Card;
