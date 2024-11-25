import React from "react";
import Card from "./MenuCard";

interface Props {}

const CardList = (props: Props) => {
  return (
    <>
      <div className="grid grid-cols-5 gap-10">
        <Card />
        <Card />
        <Card />
        <Card />
        <Card />
        <Card />
        <Card />
        <Card />
        <Card />
        <Card />
      </div>
    </>
  );
};

export default CardList;
