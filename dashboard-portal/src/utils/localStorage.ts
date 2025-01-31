import { IAuth } from "@/types/admin";

type ILocalStorageKey = {
  auth: IAuth;
};

export const useLocalStorage = () => {
  const setItem = <T extends keyof ILocalStorageKey>(key: T, value: ILocalStorageKey[T]): void => {
    try {
      localStorage.setItem(key, JSON.stringify(value));
    } catch (error) {
      console.error("Error setting item in localStorage", error);
    }
  };
  const getItem = <T extends keyof ILocalStorageKey, R extends boolean = false>(
    key: T,
    raw?: R
  ): (R extends true ? ILocalStorageKey[T] : string) | null => {
    try {
      const value = localStorage.getItem(key);
      let result: ILocalStorageKey[T] | string | null = null;
      if (value === null) {
        return result;
      }
      if (raw) {
        result = JSON.parse(value);
      } else {
        result = value;
      }

      return result as any;
    } catch (error) {
      return null;
    }
  };
  const removeItem = <T extends keyof ILocalStorageKey>(key: T): void => {
    localStorage.removeItem(key);
  };
  return { setItem, getItem, removeItem };
};
